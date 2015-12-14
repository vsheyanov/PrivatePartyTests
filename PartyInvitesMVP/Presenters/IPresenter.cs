using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PartyInvitesMVP.Presenters.Results;

namespace PartyInvitesMVP.Presenters
{
    public interface IPresenter<T>
    {
        IResult GetResult();
        IResult GetResult(T requestedData);
    }
}
