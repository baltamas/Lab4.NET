using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultimediaCenter.ViewModels.Reservations
{
    public class UpdateReservationForUser
    {
        public int Id { get; set; }
        public List<int> MovieIds { get; set; }
    }
}
