using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace portfolio.Pages
{
    public partial class Index
    {
        public bool[] _toggleContent = new bool[2];

        protected override void OnInitialized()
        {
            _toggleContent[0] = true;
            base.OnInitialized();
        }

        public void ToggleContent(int id)
        {
            for (int i = 0; i < _toggleContent.Length; i++)
            {
                _toggleContent[i] = i == id ? true : false;
            }
        }
    }
}
