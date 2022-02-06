using Pin_Projekt_N.Data;
using System.Collections.Generic;

namespace Pin_Projekt_N.Models
{
    public interface IFramesRepository
    {
        Frame getFrame(int id);
        IEnumerable<Frame> getAllFrames();
        Frame Add(Frame frame);
        Frame Update(Frame frame);
        Frame Delete(int id);
    }
}
