unit U_LogBib;

interface

uses
  Winapi.Windows, Winapi.Messages, System.SysUtils, System.Variants, System.Classes, Vcl.Graphics,
  Vcl.Controls, Vcl.Forms, Vcl.Dialogs, Vcl.ExtCtrls, Vcl.StdCtrls,
  Vcl.Imaging.pngimage;

type
  TForm1 = class(TForm)
    Timer1: TTimer;
    ComboBox1: TComboBox;
    Image1: TImage;
    imgacept: TImage;
    procedure Timer1Timer(Sender: TObject);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  Form1: TForm1;

implementation

{$R *.dfm}

procedure TForm1.Timer1Timer(Sender: TObject);
begin
  if (combobox1.Text = 'Watch Dogs Legion') then
  Begin
      image1.Picture.LoadFromFile('D:\Projetos\Projetos_RHY\Delphi 10\Google_Class\Projeto_1\IMG\icones\cp2.bmp');
  End;


end;

end.