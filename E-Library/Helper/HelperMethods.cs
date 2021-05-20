using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using System.Text;
using E_Library.Models;
using E_Library.Data;

namespace E_Library.Helper
{
    public class JwtToken
    {
        private static string key = "401b09eab3c013d4ca54922bb802bec8fd5318192b0a75f201d8b372742" +
            "9090fb337591abd3e44453b954555b7a0812e1081c39b740293f765eae731f5a65ed1";
        private static int tokenTime = 60; // * 24 * 7;
        private static JwtSecurityTokenHandler handler = new JwtSecurityTokenHandler();
        private static SymmetricSecurityKey securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key));

        public static void GenerateToken(object data, Action<string> callback)
        {
            data = data.ToJSON();
            var header = new JwtHeader(new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256));
            var PayLoad = new JwtPayload
            {
                { "data", data }
            };

            var encodeObj = new JwtSecurityToken(header, PayLoad);
            handler.TokenLifetimeInMinutes = tokenTime;

            var token = handler.WriteToken(encodeObj);
            callback(token);
        }

        public static string GenerateToken(object data)
        {
            data = data.ToJSON();
            var header = new JwtHeader(new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256));
            var PayLoad = new JwtPayload
            {
                { "data", data }
            };

            var encodeObj = new JwtSecurityToken(header, PayLoad);
            handler.TokenLifetimeInMinutes = tokenTime;
            return handler.WriteToken(encodeObj);
        }

        public static User DecodeToken(string token)
        {
            User decodedToken = new User();
            var v = handler.ReadJwtToken(token).Payload.First().Value.ToString();
            decodedToken = JsonConvert.DeserializeObject<User>(v);
            return decodedToken;
        }

        public static UsersAccount DecodeAdminToken(string token)
        {
            var tokenString = handler.ReadJwtToken(token);
            var u = tokenString.Payload.First().Value.ToString();
            return JsonConvert.DeserializeObject<UsersAccount>(u);
        }
    }

    public class Auth
    {
        static ApplicationDbContext _context = new ApplicationDbContext();
        public static User ValidateUser(User user)
        {
            return _context.Users.SingleOrDefault((u) => u.Id == user.Id);
        }

        public static UsersAccount ValidateAdmin(UsersAccount usersAccount)
        {
            return _context.UsersAccounts.SingleOrDefault((u) => u.Id == usersAccount.Id);
        }
    }
}