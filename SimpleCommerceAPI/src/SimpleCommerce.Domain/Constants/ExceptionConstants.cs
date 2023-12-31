﻿using SimpleCommerce.Domain.Models;

namespace SimpleCommerce.Domain.Constants
{
    public static class ExceptionConstants
    {
        public static readonly ExceptionConstantModel ServerSideException = new("An error has occurred with the server!");

        public static readonly ExceptionConstantModel TokenError = new("Please login, then try again!");

        public static readonly ExceptionConstantModel NotFoundUser = new("No such user is registered in the system!");

        public static readonly ExceptionConstantModel NotFoundProduct = new("There is no such product in the system!");

        public static readonly ExceptionConstantModel UnauthorizedException = new("You are not authorized!");
    }
}
