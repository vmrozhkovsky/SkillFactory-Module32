﻿namespace MvcStartApp.Models.Db;

public interface IRequestRepository
{
    Task AddRequest(Request request);
    Task<Request []> GetRequests();
}