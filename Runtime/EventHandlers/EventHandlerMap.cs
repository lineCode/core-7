using System;
using System.Collections.Generic;

namespace ReactUnity.EventHandlers
{
    public static class EventHandlerMap
    {
        static Dictionary<string, Type> EventMap = new Dictionary<string, Type>
        {
            { "onPointerClick", typeof(PointerClickHandler) },
            { "onPointerUp", typeof(PointerUpHandler) },
            { "onPointerDown", typeof(PointerDownHandler) },
            { "onPointerEnter", typeof(PointerEnterHandler) },
            { "onPointerExit", typeof(PointerExitHandler) },
            { "onSubmit", typeof(SubmitHandler) },
            { "onCancel", typeof(CancelHandler) },
            { "onSelect", typeof(SelectHandler) },
            { "onDeselect", typeof(DeselectHandler) },
            { "onMove", typeof(MoveHandler) },
            { "onUpdateSelected", typeof(UpdateSelectedHandler) },
            { "onScroll", typeof(ScrollHandler) },
            { "onDrag", typeof(DragHandler) },
            { "onBeginDrag", typeof(BeginDragHandler) },
            { "onEndDrag", typeof(EndDragHandler) },
            { "onPotentialDrag", typeof(PotentialDragHandler) },
            { "onDrop", typeof(DropHandler) },
        };

        public static Type GetEventType(string eventName)
        {
            if (EventMap.TryGetValue(eventName, out var res)) return res;
            return null;
        }
    }
}
