﻿using System;
using System.Collections.Generic;
using System.Text;
using CityBusManagement.DAL.Repository;
using CityBusManagement.Entity.Model;

namespace CityBusManagement.BAL.Service
{
    public class RouteDetailsService
    {
        IRouteDetailsRepository _routeDetailsRepository;

        public RouteDetailsService(IRouteDetailsRepository routeDetailsRepository)
        {
            _routeDetailsRepository = routeDetailsRepository;
        }
        public void AddRouteDetails(RouteDetails routedetails)
        {
            _routeDetailsRepository.AddRouteDetails(routedetails);
        }
        public void DeleteRouteDetails(int routeNo)
        {
            _routeDetailsRepository.DeleteRouteDetails(routeNo);
        }
        public void UpdateRouteDetails(RouteDetails routedetails)
        {
            _routeDetailsRepository.UpdateRouteDetails(routedetails);
        }
        public void GetRouteNo(int routeNo)
        {
           _routeDetailsRepository.GetRouteNo(routeNo);
        }




    }
}
