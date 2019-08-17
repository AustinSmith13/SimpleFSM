using System;
using System.Collections.Generic;

namespace SimpleFsm {
    public class Machine : IMachine {
        private SState current;
        private SState initial;
        private IDictionary<Type, SState> states;
        private IDictionary<Type, FactoryFunc<SState>> factories;

        public IState GetCurrentState () {
            return this.current;
        }

        public IState GetInitialState () {
            return this.initial;
        }

        public void Execute () {
            this.current.Execute ();
        }

        public void Reset () {
            //TODO: implement this
        }

        public void Process (string action) {

        }

        public ITransitionGraph In<T> () where T : SState, new () {
            return this.Get<T> ().TransitionGraph;
        }

        public void AddFactoryFor<T> (FactoryFunc<T> method) where T : SState {

        }

        public T Get<T> () where T : SState, new () {
            SState state = null;

            this.states.TryGetValue (typeof (T), out state);

            if (state != null) {
                return (T) state;
            }

            FactoryFunc<SState> factoryMethod = null;

            this.factories.TryGetValue (typeof (T), out factoryMethod);

            if (factoryMethod != null) {
                return (T) factoryMethod.Invoke ();
            }

            var newState = new T ();
            newState.Context = this;

            return newState;
        }
    }
}