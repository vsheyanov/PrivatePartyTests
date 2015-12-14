using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using PartyInvitesMVP.Model;
using PartyInvitesMVP.Model.Repository;
using PartyInvitesMVP.Presenters.Results;

namespace PartyInvitesMVP.Presenters
{
    public class RSVPPresenter : IPresenter<GuestResponse>
    {
        public IRepository repository { get; set; }

        IResult IPresenter<GuestResponse>.GetResult()
        {
            return new DataResult<GuestResponse>(new GuestResponse());
        }

        IResult IPresenter<GuestResponse>.GetResult(GuestResponse requestedData)
        {
            repository.AddResponse(requestedData);

            if (requestedData.WillAttend.Value)
            {
                return new RedirectResult("/Content/seeyouthere.html");
            } else
            {
                return new RedirectResult("/Content/sorryyoucantcome.html");
            }
        }
    }
}