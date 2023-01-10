namespace Domain.Services
{
  using System;
  using System.Linq;
  using Domain.Models;
  using Domain.Repositories;

  /// <summary>
  /// Class of the user's function.
  /// </summary>
  public class UserServiece
  {
    private readonly IRepository<User> userRepository;
    private readonly IRepository<UserSession> userSessionRepository;

    /// <summary>
    /// Initializes a new instance of the <see cref="UserServiece"/> class.
    /// </summary>
    /// <param name="userRepository">Users repository.</param>
    /// <param name="userSessionRepository">User sessions repository.</param>
    public UserServiece(IRepository<User> userRepository, IRepository<UserSession> userSessionRepository)
    {
      this.userRepository = userRepository;
      this.userSessionRepository = userSessionRepository;
    }

    /// <summary>
    /// Create new user.
    /// </summary>
    /// <param name="name">User name.</param>
    /// <param name="login">User login.</param>
    /// <param name="password">Password login.</param>
    /// <returns>New user.</returns>
    public User CreateUser(string name, string login, string password)
    {
      var user = new User(name, login, password);
      this.userRepository.Save(user);
      return user;
    }

    /// <summary>
    /// Get user.
    /// </summary>
    /// <param name="id">User id.</param>
    /// <returns>User.</returns>
    public User GetUser(int id)
    {
      return this.userRepository.Get(id);
    }

    /// <summary>
    /// Delete user.
    /// </summary>
    /// <param name="user">User.</param>
    public void DeleteUser(User user)
    {
      this.userRepository.Delete(user);
    }

    /// <summary>
    /// Delete user sessions.
    /// </summary>
    /// <param name="user">User.</param>
    public void DeleteUserSessions(User user)
    {
      var userSessions = this.userSessionRepository.GetAll(s => Equals(s.User, user));

      foreach (var session in userSessions)
      {
        this.userSessionRepository.Delete(session);
      }
    }

    /// <summary>
    /// Create new session.
    /// </summary>
    /// <param name="user">User created session.</param>
    /// <param name="sessionBegin">Session begin.</param>
    /// <returns>New user sesseion.</returns>
    public UserSession CreateSession(User user, DateTime sessionBegin)
    {
      var userSession = new UserSession(sessionBegin)
      {
        User = user,
      };
      this.userSessionRepository.Save(userSession);
      return userSession;
    }

    /// <summary>
    /// Complete user session.
    /// </summary>
    /// <param name="user">User.</param>
    /// <param name="sessionEnd">Session.</param>
    public void CompleteSession(User user, DateTime sessionEnd)
    {
      var userSession = this.userSessionRepository.GetAll(s => s.SessionEnd == null && Equals(s.User, user)).FirstOrDefault();

      if (userSession is not null)
      {
        userSession.SessionEnd = sessionEnd;
        this.userSessionRepository.Save(userSession);
      }
    }
  }
}
