namespace Interfaces.Smash
{
    public interface ICharacter
    {
        void SetHorizontalDirection(float dx);
        void PerformAttack();
        void StartJump();
    }
}
