using Exiled.API.Features;
using System;
using Player = Exiled.Events.Handlers.Player;

namespace Scp207 {
    public class Main : Plugin<Config> {
        public override string Author => "Celestine-Lux";
        public override string Name => "207nh";
        public override Version Version => new Version("1.0.0.0");
        public Main Instance;
        private EventHandlers eventHandlers;
        public override void OnEnabled() {
            base.OnEnabled();
            Instance = this;
            eventHandlers = new EventHandlers();
            Player.Hurting += eventHandlers.PlayerHurting;
        }
        public override void OnDisabled() { 
            base.OnDisabled();
            Player.Hurting -= eventHandlers.PlayerHurting;
            Instance = null;
            eventHandlers = null;
        }
    }
}
