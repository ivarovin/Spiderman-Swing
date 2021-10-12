namespace Swing.Cobweb
{
    public class CobwebTargetFinder
    {
        private readonly CobwebTargetsDetector cobwebsDetector;
        private readonly CobwebTargetGetter cobwebGetter;

        public CobwebTargetFinder(CobwebTargetsDetector _cobwebsDetector,
                                  CobwebTargetGetter _cobwebsGetter)
        {
            cobwebsDetector = _cobwebsDetector;
            cobwebGetter = _cobwebsGetter;
        }

        public void FindAvailableCobweb()
        {
            cobwebGetter.FindAvailableCobweb(cobwebsDetector.DetectCobwebTargets());
        }
    }
}