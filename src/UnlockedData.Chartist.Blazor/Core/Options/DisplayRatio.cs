using System.ComponentModel;

namespace UnlockedData.Chartist.Blazor;

public enum DisplayRatio
{
    [Description("ct-golden-section")] GoldenSection,
    [Description("ct-square")] Square,
    [Description("ct-minor-second")] MinorSecond,
    [Description("ct-major-second")] MajorSecond,
    [Description("ct-minor-third")] MinorThird,
    [Description("ct-major-third")] MajorThird,
    [Description("ct-perfect-fourth")] PerfectFourth,
    [Description("ct-perfect-fifth")] PerfectFifth,
    [Description("ct-minor-sixth")] MinorSixth,
    [Description("ct-major-sixth")] MajorSixth,
    [Description("ct-minor-seventh")] MinorSeventh,
    [Description("ct-major-seventh")] MajorSeventh,
    [Description("ct-octave")] Octave,
    [Description("ct-major-tenth")] MajorTenth,
    [Description("ct-major-eleventh")] MajorEleventh,
    [Description("ct-major-twelfth")] MajorTwelfth,
    [Description("ct-double-octave")] DoubleOctave
}
