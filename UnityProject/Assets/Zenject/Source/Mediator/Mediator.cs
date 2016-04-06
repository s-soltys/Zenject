using UnityEngine;
using System.Collections;

namespace Zenject
{
    public abstract class Mediator<V> : MonoBehaviour
        where V : MonoBehaviour
    {
        protected V View { get; set; }
    }
}
