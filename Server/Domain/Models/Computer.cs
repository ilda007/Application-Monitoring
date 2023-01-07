﻿namespace Domain.Models
{
  using System;

  /// <summary>
  /// Computer class.
  /// </summary>
  public class Computer : Entity
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="Computer"/> class.
    /// </summary>
    /// <param name="login">Login.</param>
    /// <param name="name">Computer name.</param>
    /// <param name="ip">Ip address.</param>
    /// <param name="application">Application.</param>
    /// <param name="note">Note.</param>
    public Computer(string login, string name, string ip, Application application, string note = null)
    {
      this.Login = login;
      this.Name = name;
      this.Ip = ip;
      this.Application = application;
      this.Note = note;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Computer"/> class.
    /// </summary>
    private Computer()
    {
    }

    /// <summary>
    /// Gets computer login.
    /// </summary>
    public string Login { get; }

    /// <summary>
    /// Gets or sets computer Ip.
    /// </summary>
    public string Ip { get; set; }

    /// <summary>
    /// Gets or sets computer name.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Gets or sets computer name owner.
    /// </summary>
    public string Username { get; set; }

    /// <summary>
    /// Gets or sets last session begin.
    /// </summary>
    public DateTime LastActivity { get; set; }

    /// <summary>
    /// Gets or sets last session long.
    /// </summary>
    public DateTime SessionLong { get; set; }

    /// <summary>
    /// Gets or sets application.
    /// </summary>
    public Application Application { get; set; }

    /// <summary>
    /// Gets or sets note.
    /// </summary>
    public string Note { get; set; }
  }
}
