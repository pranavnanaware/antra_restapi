﻿using Order.ApplicationCore.Model.Request;
using Order.ApplicationCore.Model.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.ApplicationCore.Contracts.Services
{
    public interface IOrderServiceAsync
    {
        Task<int> DeleteOrder(int id);
        Task<IEnumerable<OrderResponseModel>> GetAllAsync();
        Task<OrderResponseModel> GetOrderById(int id);
        Task<int> InsertOrder(OrderRequestModel model);
        Task<int> UpdateOrder(OrderRequestModel model, int id);
        Task<IEnumerable<OrderResponseModel>> GetOrderByCustomerId(int customerId);
    }
}
