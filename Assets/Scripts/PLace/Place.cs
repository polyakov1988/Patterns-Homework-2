using UnityEngine;

namespace PLace
{
    public abstract class Place : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            if (other.TryGetComponent(out Character character) == false)
            {
                return;
            }
            
            DoAction(character);
        } 
        
        protected abstract void DoAction(Character character);
    }
}