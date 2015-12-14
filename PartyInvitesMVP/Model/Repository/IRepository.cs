using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PartyInvitesMVP.Model.Repository
{
    public interface IRepository
    {
        IEnumerable<GuestResponse> GetAllResponses();

        void AddResponse (GuestResponse response);
    }
}