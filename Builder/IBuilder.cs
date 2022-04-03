using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Builder
{
    // Builders common interface
    public interface IBuilder
    {
        void StartUpOperations();
        void BuildBody();
        void InsertWheels();
        void AddHeadlights();
        void EndOperations();
        Product GetVehicle();
    }
}
