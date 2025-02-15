using Characters.Player;
using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

namespace Environment.Room
{
    public class RoomComputer : MonoBehaviour, IInteractable
    {
        public GameObject ComputerCameraPosition;
        [SerializeField] private bool _isInteractable;
        [SerializeField] private bool _isLocked;

        [SerializeField] private UnityEvent _computerOnEvent;

        // Start is called before the first frame update
        void Start()
        {
            _isInteractable = true;
            _isLocked = false;
        }

        public bool IsInteractable => _isInteractable;

        public void Hover(Vector3 CameraPosition, Vector3 hitPoint)
        {
        }

        public void Interact(Vector3 CameraPosition, Vector3 hitPoint)
        {
            Sequence seq = DOTween.Sequence();
            _isInteractable = false;

            seq.PrependInterval(0.5f);
            seq.AppendCallback(() =>
            {
                _isInteractable = true;
            });

            if (!_isLocked)
            {
                // Unlock
                _isLocked = true;
                PlayerManager.Instance.Camera.LockCameraToPosition(ComputerCameraPosition, _computerOnEvent);
            }
            else
            {
                _isLocked = false;
                PlayerManager.Instance.Camera.ReturnCamToNormal();
            }
        }

        public void StopHover()
        {
        }
    }
}