unit UClientes;

interface

uses
  Winapi.Windows, Winapi.Messages, System.SysUtils, System.Variants, System.Classes, Vcl.Graphics,
  Vcl.Controls, Vcl.Forms, Vcl.Dialogs, Vcl.StdCtrls, Vcl.ComCtrls, Vcl.Buttons,
  Vcl.Mask, Vcl.DBCtrls, Data.Db, Vcl.ExtCtrls, Vcl.Imaging.pngimage;

type
  TFrmClientes = class(TForm)
    PC_Clientes: TPageControl;
    tb_cadastro: TTabSheet;
    lb_nome: TLabel;
    Label19: TLabel;
    Image1: TImage;
    Image2: TImage;
    Image3: TImage;
    imgacept: TImage;
    imgback: TImage;
    txtName: TDBEdit;
    txtCPF: TDBEdit;
    TabSheet1: TTabSheet;
    Image4: TImage;
    Image5: TImage;
    DBEdit1: TDBEdit;
    Image6: TImage;
    DBEdit2: TDBEdit;
    Image7: TImage;
    Image8: TImage;


    procedure imgaceptClick(Sender: TObject);
    procedure imgbackClick(Sender: TObject);
  private

  public
    { Public declarations }
  end;

var
  FrmClientes: TFrmClientes;

implementation

{$R *.dfm}

uses U_DM, U_LogBib;


procedure TFrmClientes.imgaceptClick(Sender: TObject);
begin
// Inserir na tabela
  DM.tb_Clientes.Active:= true;
  DM.tb_Clientes.Insert;

// Desabilitando bot�es


// Tratar Data

end;

procedure TFrmClientes.imgbackClick(Sender: TObject);
begin
  Form1.Show;
end;

end.
