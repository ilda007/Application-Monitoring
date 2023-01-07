namespace Domain.Services
{
  using System;
  using System.Linq;
  using Domain.Models;
  using Domain.Repositories;

  /// <summary>
  /// Computer service class.
  /// </summary>
  public class ComputerService
  {
    private readonly IRepository<Computer> computerRepository;
    private readonly IRepository<ComputerSession> computerSessionRepository;

    /// <summary>
    /// Initializes a new instance of the <see cref="ComputerService"/> class.
    /// </summary>
    /// <param name="computerRepository">Computer repository.</param>
    /// <param name="computerSessionRepository">Computer session repository.</param>
    public ComputerService(IRepository<Computer> computerRepository, IRepository<ComputerSession> computerSessionRepository)
    {
      this.computerRepository = computerRepository;
      this.computerSessionRepository = computerSessionRepository;
    }

    /// <summary>
    /// Register new computer.
    /// </summary>
    /// <param name="login">Login computer.</param>
    /// <param name="name">Name computer.</param>
    /// <param name="ip">Ip computer.</param>
    /// <param name="application">Application.</param>
    /// <param name="note">Note.</param>
    /// <returns>New computer.</returns>
    public Computer RegisterComputer(string login, string name, string ip, Application application, string note)
    {
      var computer = new Computer(login, name, ip, application, note);
      this.computerRepository.Save(computer);
      return computer;
    }

    /// <summary>
    /// Create new session.
    /// </summary>
    /// <param name="computer">Computer.</param>
    /// <param name="sessionBegin">Session begin.</param>
    /// <returns>Computer session.</returns>
    public ComputerSession CreateSession(Computer computer, DateTime sessionBegin)
    {
      var session = new ComputerSession(computer, sessionBegin);
      computer.LastActivity = session.SessionBegin;
      this.computerSessionRepository.Save(session);
      this.computerRepository.Save(computer);
      return session;
    }

    /// <summary>
    /// Complete session.
    /// </summary>
    /// <param name="computer">Computer.</param>
    /// <param name="sessionEnd">Session end.</param>
    public void CompleteSession(Computer computer, DateTime sessionEnd)
    {
      var session = this.computerSessionRepository.GetAll(s => Equals(s.Computer, computer) && s.SessionEnd == null).FirstOrDefault();

      if (session is not null)
      {
        session.SessionEnd = sessionEnd;
        computer.SessionLong = sessionEnd - computer.LastActivity;
        this.computerSessionRepository.Save(session);
        this.computerRepository.Save(computer);
      }
    }

    /// <summary>
    /// Get computer session.
    /// </summary>
    /// <param name="id">Session id.</param>
    /// <returns>Computer session.</returns>
    public ComputerSession GetComputerSession(int id)
    {
      var computerSession = this.computerSessionRepository.Get(id);
      return computerSession;
    }

    /// <summary>
    /// Get  computer.
    /// </summary>
    /// <param name="id">Computer Id.</param>
    /// <returns>Computer.</returns>
    public Computer GetComputer(int id)
    {
      var computer = this.computerRepository.Get(id);
      return computer;
    }
  }
}
