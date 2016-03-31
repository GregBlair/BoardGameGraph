using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGameGraph.Database
{
    struct PlayEntry
    {
        uint XDestination;
        uint YDestination;
        uint XStart;
        uint YStart;
        string NextEntry;
        string Symmetry;
    }

    interface IDatabase
    {
        string createPlay(PlayEntry entry);
        string createMove(PlayEntry entry);
    }
}
