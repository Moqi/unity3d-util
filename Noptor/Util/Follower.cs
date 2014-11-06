using UnityEngine;
using System.Collections;

namespace Noptor.Util
{
    /// <summary>
    /// Следователь — позволяет закреплять один объект за другим при перемещении;
    /// в отличие от <see cref="Transform.parent"/>, не вращает объект.
    /// </summary>
    public class Follower : MonoBehaviour
    {

        /// <summary>
        /// Сгдвиг относительно родителя
        /// </summary>
        public Vector3 Offset = Vector3.zero;

        /// <summary>
        /// Цель, за которой следует объект
        /// </summary>
        public Transform Target;
	
        /// <summary>
        /// Следование за целью
        /// </summary>
        protected void LateUpdate()
        {
            transform.position = Target.position + Offset;
        }
    }
}
