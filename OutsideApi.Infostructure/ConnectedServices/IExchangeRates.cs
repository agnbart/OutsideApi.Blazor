using OutsideApi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutsideApi.Infostructure.ConnectedServices
{
    public interface IExchangeRates
    {
        Task<Currency> Retrive(string currency, string numberOfResults);
    }
}
