// Command line tool to keep computer alive and prevent sleep
namespace KeepAlive {
    class KeepAlive {
        static void Main(string[] args) {
            PowerHelper.ForceSystemAwake();
        }
    }
}
