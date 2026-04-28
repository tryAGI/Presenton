
#nullable enable

namespace Presenton
{
    /// <summary>
    /// 
    /// </summary>
    public enum QualitativeChart
    {
        /// <summary>
        /// 
        /// </summary>
        Comparison,
        /// <summary>
        /// 
        /// </summary>
        Funnel,
        /// <summary>
        /// 
        /// </summary>
        GanttChart,
        /// <summary>
        /// 
        /// </summary>
        Infographics,
        /// <summary>
        /// 
        /// </summary>
        JourneyMap,
        /// <summary>
        /// 
        /// </summary>
        LadderChart,
        /// <summary>
        /// 
        /// </summary>
        MatrixChart,
        /// <summary>
        /// 
        /// </summary>
        OrganizationChart,
        /// <summary>
        /// 
        /// </summary>
        PyramidChart,
        /// <summary>
        /// 
        /// </summary>
        Roadmap,
        /// <summary>
        /// 
        /// </summary>
        SequenceDiagram,
        /// <summary>
        /// 
        /// </summary>
        StatsChart,
        /// <summary>
        /// 
        /// </summary>
        Steps,
        /// <summary>
        /// 
        /// </summary>
        SwotChart,
        /// <summary>
        /// 
        /// </summary>
        Timeline,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class QualitativeChartExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this QualitativeChart value)
        {
            return value switch
            {
                QualitativeChart.Comparison => "comparison",
                QualitativeChart.Funnel => "funnel",
                QualitativeChart.GanttChart => "gantt_chart",
                QualitativeChart.Infographics => "infographics",
                QualitativeChart.JourneyMap => "journey_map",
                QualitativeChart.LadderChart => "ladder_chart",
                QualitativeChart.MatrixChart => "matrix_chart",
                QualitativeChart.OrganizationChart => "organization_chart",
                QualitativeChart.PyramidChart => "pyramid_chart",
                QualitativeChart.Roadmap => "roadmap",
                QualitativeChart.SequenceDiagram => "sequence_diagram",
                QualitativeChart.StatsChart => "stats_chart",
                QualitativeChart.Steps => "steps",
                QualitativeChart.SwotChart => "swot_chart",
                QualitativeChart.Timeline => "timeline",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static QualitativeChart? ToEnum(string value)
        {
            return value switch
            {
                "comparison" => QualitativeChart.Comparison,
                "funnel" => QualitativeChart.Funnel,
                "gantt_chart" => QualitativeChart.GanttChart,
                "infographics" => QualitativeChart.Infographics,
                "journey_map" => QualitativeChart.JourneyMap,
                "ladder_chart" => QualitativeChart.LadderChart,
                "matrix_chart" => QualitativeChart.MatrixChart,
                "organization_chart" => QualitativeChart.OrganizationChart,
                "pyramid_chart" => QualitativeChart.PyramidChart,
                "roadmap" => QualitativeChart.Roadmap,
                "sequence_diagram" => QualitativeChart.SequenceDiagram,
                "stats_chart" => QualitativeChart.StatsChart,
                "steps" => QualitativeChart.Steps,
                "swot_chart" => QualitativeChart.SwotChart,
                "timeline" => QualitativeChart.Timeline,
                _ => null,
            };
        }
    }
}