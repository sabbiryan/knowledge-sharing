using System.ComponentModel;

namespace KS.Core.Models.Emums
{
    public enum Rating
    {
        Low = 1,
        Moderate = 2,
        Good= 3,

        [Description("Very Good")]
        VeryGood = 4,
        Expert = 5
    }
}