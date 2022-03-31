using SWP_Xamarin_Hotel.Models;
using SWP_Xamarin_Hotel.Models.Common;

namespace SWP_Xamarin_Hotel.ViewModels
{
    internal class RoomDetailsViewModel : BindingBase
    {
        private Room _room;
        public Room Room
        {
            get { return _room; }
            set
            {
                _room = value;
                this.RaisePropertyChanged(nameof(Room));
            }
        }


    }
}
