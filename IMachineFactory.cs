namespace SimpleFsm {
    public interface IMachineFactory {
        ITransitionGraph In<T> () where T : SState, new ();
        void AddFactoryFor<T> (FactoryFunc<T> method) where T : SState;
    }
}