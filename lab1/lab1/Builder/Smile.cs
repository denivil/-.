using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1.Builder
{
    internal class Smile
    {
        private Head _head;
        private Mouth _mouth;
        private Eyes _eyes;

        public Head Head => _head;
        public Mouth Mouth => _mouth;
        public Eyes Eyes => _eyes;


        public void SetHead(Head head)
        {
            _head = head;
        }

        public void SetMouth(Mouth mouth)
        {
            _mouth = mouth;
        }

        public void SetEyes(Eyes eyes)
        {
            _eyes = eyes;
        }
    }
}
