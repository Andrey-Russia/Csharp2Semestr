public interface IExtremeTransport
{

    bool CanDoStunts { get; }
    string PerformStunt();
    double RiskFactor { get; }
}