using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using System.Linq;
using System.Collections.Generic;

using PartyInvitesMVP.Model;
using PartyInvitesMVP.Model.Repository;
using PartyInvitesMVP.Presenters;
using PartyInvitesMVP.Presenters.Results;

namespace PartyInvites.Tests
{
    [TestClass]
    public class RSVPPresenterTests
    {
        class MockRepository : IRepository
        {
            private List<GuestResponse> mockData = new List<GuestResponse>
            {
                new GuestResponse() { Name = "Person 1", WillAttend = true },
                new GuestResponse() { Name = "Person 2", WillAttend = false }
            };

            public void AddResponse(GuestResponse response)
            {
                mockData.Add(response);
            }

            public IEnumerable<GuestResponse> GetAllResponses()
            {
                return mockData;
            }
        }


        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
