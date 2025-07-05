using UnityEngine;
using ValidationAttributes;
namespace BetterPlayerController
{
    public class PlayerController : MonoBehaviour
    {
        #region Fields
        [SerializeField, Required] InputReader inputReader;
        #endregion
    }
}