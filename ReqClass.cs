using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequirmentPlus
{
    public class ReqClass : RequirementCheck
    {
        public override string Name => "Noodle Extensions";

        public override RequirementType IsRequiredOrSuggested(BeatSaberSong.DifficultyBeatmap mapInfo, BeatSaberMap map)
        {
            return RequirementType.Requirement;
        }
    }
}
