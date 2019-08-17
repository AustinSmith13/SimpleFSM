namespace SimpleFsm {
    public interface IState {
        void Enter ();
        void Exit ();
        void Execute ();

    }
}