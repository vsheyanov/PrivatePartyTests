using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Web.ModelBinding;

using PartyInvitesMVP.Model;
using PartyInvitesMVP.Model.Repository;
using PartyInvitesMVP.Presenters;
using PartyInvitesMVP.Presenters.Results;

namespace PartyInvitesMVP.Pages
{
    public partial class Default : System.Web.UI.Page
    {
        public IPresenter<GuestResponse> presenter { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                return;

            presenter = new RSVPPresenter() { repository = new MemoryRepository() };

            GuestResponse response = ((DataResult<GuestResponse>)presenter.GetResult()).DataItem;

            if (TryUpdateModel( response, new FormValueProvider(ModelBindingExecutionContext)))
            {
                Response.Redirect(((RedirectResult)presenter.GetResult(response)).Url);
            }
        }
    }
}