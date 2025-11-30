using Exiled.Events.EventArgs.Player;

namespace Scp207 {
    public class EventHandlers {
        public void PlayerHurting(HurtingEventArgs ev) {
            if (ev.Player == null)
                return;
            if (ev.DamageHandler.Type != Exiled.API.Enums.DamageType.Scp207)
                return;
            ev.Amount = 0f;
        }
    }
}
