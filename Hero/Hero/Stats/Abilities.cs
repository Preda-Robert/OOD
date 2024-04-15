using Hero.Characters;

namespace Hero.Stats
{
    interface Abilities
    {
        void Cast(Character caster, Character enemy);

        bool isLucky();
    }
}
