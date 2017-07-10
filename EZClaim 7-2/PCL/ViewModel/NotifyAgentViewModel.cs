using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZClaim.ViewModel
{
    public class NotifyAgentViewModel : ViewModelBase
    {

        public NotifyAgentViewModel() { }

        private string _notifyAutoAgent = "Notify Auto Agent";
        public String NotifyAutoAgent
        {
            get
            {
                return _notifyAutoAgent;
            }
            set
            {
                _notifyAutoAgent = value;
                OnPropertyChanged("NotifyAutoAgent");
            }
        }

        private string _notifyHomeAgent = "Notify Home Agent";
        public String NotifyHomeAgent
        {
            get
            {
                return _notifyHomeAgent;
            }
            set
            {
                _notifyHomeAgent = value;
                OnPropertyChanged("NotifyHomeAgent");
            }
        }

    }
}
