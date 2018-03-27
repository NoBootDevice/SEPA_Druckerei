import { Routes, RouterModule} from '@angular/router';
import { AccountOwnerComponent } from './app.accountowner';

const routes: Routes = [
    
    {path: 'AccountOwner', component: AccountOwnerComponent},
  
 /*   {path: 'TransactionSample', component: TransactionSampleComponent}, 
    {path: 'TransactionUsage', component: TransactionUsageComponent},
    {path: 'NewTransaction', component: NewTransactionComponent}, 
  
    {path: 'BackupIntervall', component: BackupIntervallComponent},
    {path: 'NewBackup', component: NewBackupComponent}, 
    {path: 'LoadBackup', component: LodBackupComponent}*/
];

export const routing = RouterModule.forRoot(routes);