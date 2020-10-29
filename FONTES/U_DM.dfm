object DM: TDM
  OldCreateOrder = False
  OnCreate = DataModuleCreate
  Height = 361
  Width = 526
  object FDGUIxWaitCursor1: TFDGUIxWaitCursor
    Provider = 'Forms'
    Left = 208
    Top = 128
  end
  object FDConnection2: TFDConnection
    Params.Strings = (
      'DriverID=MySQL'
      'User_Name=root')
    Connected = True
    Left = 72
    Top = 256
  end
  object Driver: TFDPhysMySQLDriverLink
    VendorLib = 
      'D:\Projetos\Projetos_RHY\Delphi 10\Google_Class\Projeto_1\lib\li' +
      'bmySQL.dll'
    Left = 176
    Top = 256
  end
  object FDTable1: TFDTable
    Left = 272
    Top = 256
  end
  object DataSource2: TDataSource
    DataSet = FDTable1
    Left = 360
    Top = 256
  end
end
