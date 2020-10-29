unit U_Principal;

interface

uses
  Winapi.Windows, Winapi.Messages, System.SysUtils, System.Variants, System.Classes, Vcl.Graphics,
  Vcl.Controls, Vcl.Forms, Vcl.Dialogs, Vcl.ExtCtrls, Vcl.Menus, Vcl.ComCtrls,
  Vcl.StdCtrls, Vcl.Buttons;

type
  TFrmPrincipal = class(TForm)
    Timer1: TTimer;
    ProgressBar1: TProgressBar;
    Label1: TLabel;
    procedure FecharClick(Sender: TObject);
    procedure Sair1Click(Sender: TObject);
    procedure BitBtn1Click(Sender: TObject);
    procedure Timer1Timer(Sender: TObject);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  FrmPrincipal: TFrmPrincipal;

implementation

{$R *.dfm}

uses UClientes;

procedure TFrmPrincipal.BitBtn1Click(Sender: TObject);
begin
  FrmClientes.Show;
end;

procedure TFrmPrincipal.FecharClick(Sender: TObject);
begin
  Application.Terminate;
end;

procedure TFrmPrincipal.Sair1Click(Sender: TObject);
begin
  Application.Terminate;
end;

procedure TFrmPrincipal.Timer1Timer(Sender: TObject);
begin
  if( progressbar1.Position <100) then
  begin
    progressbar1.Position := progressbar1.Position + 30;
  end
  else
  begin
  timer1.Enabled := false;
    FrmClientes.Show;
  end;
end;

end.
