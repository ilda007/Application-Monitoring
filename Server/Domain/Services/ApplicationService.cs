namespace Domain.Services
{
  using Domain.Models;
  using Domain.Repositories;

  /// <summary>
  /// Application service class.
  /// </summary>
  public class ApplicationService
  {
    private readonly IRepository<Application> applicationRepository;

    /// <summary>
    /// Initializes a new instance of the <see cref="ApplicationService"/> class.
    /// </summary>
    /// <param name="applicationRepository">Application repository.</param>
    public ApplicationService(IRepository<Application> applicationRepository)
    {
      this.applicationRepository = applicationRepository;
    }

    /// <summary>
    /// Create new application.
    /// </summary>
    /// <param name="applicationType">Application type.</param>
    /// <param name="name">Name.</param>
    /// <param name="level">Level.</param>
    /// <param name="size">Size.</param>
    /// <returns>New application.</returns>
    public Application CreateApplication(ApplicationType applicationType, string name, int level, double size)
    {
      var applocaion = new Application(applicationType, name, level, size);
      this.applicationRepository.Save(applocaion);
      return applocaion;
    }

    /// <summary>
    /// Get application.
    /// </summary>
    /// <param name="id">Application id.</param>
    /// <returns>Application.</returns>
    public Application GetApplication(int id)
    {
      return this.applicationRepository.Get(id);
    }
  }
}
