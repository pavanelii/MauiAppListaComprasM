using MauiAppListaComprasM.Helpers;

namespace MauiAppListaComprasM
{
    public partial class App : Application
    {
        static SQLiteDataBaserHelper _db;
        
        public static SQLiteDataBaserHelper Db
        {
            get
            {
                if (_db == null)
                {
                    string path = Path.Combine(
                        Environment.GetFolderPath(
                            Environment.SpecialFolder.LocalApplicationData
                            ), "banco_sqlite_compras.db3"
                            );
                    _db = new SQLiteDataBaserHelper( path );
                }
            
                return _db;
            
            }
        }
    
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    
    
    }
}
