using System;
using System.Collections.Generic;
using System.Text;

namespace S7_DependencyService
{
    public interface ITextToSpeech
    {
        void Speak(string text);
    }
}
