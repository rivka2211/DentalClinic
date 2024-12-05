using DentalClinic.API.Controllers;
using DentalClinic.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalTest
{
    public class ClientControlerTests
    {
        private readonly ClientController _clientContorller;
        private readonly FakeContext fakeContext;

        public ClientControlerTests()
        {
            _clientContorller = new ClientController(fakeContext);
        }


        [Fact]
        public void GetAll_ReturnsOK()
        {
            var result = _clientContorller.Get();

            Assert.IsType<List<Client>>(result);
        }
    }
}
