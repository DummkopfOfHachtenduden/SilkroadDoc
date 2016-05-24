4   uint    elementCount
foreach(element)
{
    64  string  element.Name
    256 string  element.Image
    256 string  element.Background
    128 string  element.Text                      //UI_STRING
    64  string  element.Description
    64  string  element.Prototype                 //placeholder (lorem ipsum)
    4   uint    element.Type                      //NewInterfaceType
    4   uint    element.Id
    4   uint    element.ParentId
    4   uint    element.GrandParentId
    4   uint    element.Unk02
    4   uint    element.Unk03
    4   uint    element.Color                     //PixelFormat.RGBA_8888
    4   uint    element.ClientRectangle.X
    4   uint    element.ClientRectangle.Y
    4   uint    element.ClientRectangle.Width
    4   uint    element.ClientRectangle.Height
    4   float   element.TopLeft.X                 //UV mapping
    4   float   element.TopLeft.Y                 //UV mapping
    4   float   element.TopRight.X                //UV mapping
    4   float   element.TopRight.Y                //UV mapping
    4   float   element.BottomRight.X             //UV mapping
    4   float   element.BottomRight.Y             //UV mapping
    4   float   element.BottomLeft.X              //UV mapping
    4   float   element.BottomLeft.Y              //UV mapping
    4   uint    element.Unk04                     //CommandID?
    4   uint    element.ContentId                 //used on TabButton and is pointing to a Frame
    4   uint    element.IsRoot
    4   uint    element.Unk07
    4   uint    element.Unk08
    4   uint    element.Unk09
    4   uint    element.Unk10
    4   uint    element.Unk11
    4   uint    element.Unk12
    4   uint    element.Unk13
    4   uint    element.Unk14
    4   uint    element.Unk15
    4   uint    element.Unk16
    4   uint    element.Unk17
    4   uint    element.Unk18
    4   uint    element.Unk19
    4   uint    element.Style                     //NewInterfaceStyle
}