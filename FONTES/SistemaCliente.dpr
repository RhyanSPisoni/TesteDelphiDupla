program SistemaCliente;

uses
  Vcl.Forms,
  U_Principal in 'U_Principal.pas' {FrmPrincipal},
  U_DM in 'U_DM.pas' {DM: TDataModule},
  UClientes in 'UClientes.pas' {FrmClientes},
  U_LogBib in 'U_LogBib.pas' {Form1};

{$R *.res}

begin
  Application.Initialize;
  Application.MainFormOnTaskbar := True;
  Application.CreateForm(TFrmPrincipal, FrmPrincipal);
  Application.CreateForm(TDM, DM);
  Application.CreateForm(TFrmClientes, FrmClientes);
  Application.CreateForm(TForm1, Form1);
  Application.Run;
end.
