﻿namespace MvcStartApp.Models.Db;

public interface IBlogRepository
{
    Task AddUser(User user);
}