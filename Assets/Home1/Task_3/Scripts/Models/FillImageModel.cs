using Task_3.Scripts.Behaviours;
using UnityEngine;

namespace Task_3.Scripts.Models {
    public class FillImageModel {
        private readonly FillImageBehaviour _fillImageBehaviour;

        public FillImageModel(
        FillImageBehaviour fillImageBehaviour
        ) {
            _fillImageBehaviour = fillImageBehaviour;
        }

        public void UpdateFillImage(float newFillValue) {
            newFillValue = Mathf.Clamp01(newFillValue);
            _fillImageBehaviour.UpdateImage(newFillValue);
        }
    }
}