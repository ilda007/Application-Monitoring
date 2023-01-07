﻿namespace Domain
{
  /// <summary>
  /// User class.
  /// </summary>
  public class User : Entity
  {

    /// <summary>
    /// Initializes a new instance of the <see cref="User"/> class.
    /// </summary>
    /// <param name="name">User name.</param>
    /// <param name="login">User login.</param>
    /// <param name="password">User  password.</param>
    public User(string name, string login, string password)
    {
      this.Name = name;
      this.Login = login;
      this.Password = password;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="User"/> class.
    /// Default constructor.
    /// </summary>
    private User()
    {
    }

    /// <summary>
    /// Gets user login.
    /// </summary>
    public string Login { get; }

    /// <summary>
    /// Gets or sets user name.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Gets or sets user password.
    /// </summary>
    public string Password { get; set; }
  }
}
