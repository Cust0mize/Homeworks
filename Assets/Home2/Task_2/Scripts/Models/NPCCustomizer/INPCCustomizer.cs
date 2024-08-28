using Home2.Task_2.Scripts.Behaviours;

namespace Home2.Task_2.Scripts.Models.NPCCustomizers {
    public interface INPCCustomizer {
        public NPCController Customize(NPCController nPCController);
    }
}
