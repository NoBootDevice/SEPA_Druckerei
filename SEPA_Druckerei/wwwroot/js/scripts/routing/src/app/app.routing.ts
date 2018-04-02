import { Routes, RouterModule} from '@angular/router';
import { TransactionformComponent } from './app.transactionformcomponent';

const routes: Routes = [
    
    {path: 'TransactionForm', component: TransactionformComponent},
    {path: 'AccountOwner', redirectTo: '/AccountOwnerView'},
    
 /*   {path: 'TransactionSample', component: TransactionSampleComponent}, 
    {path: 'TransactionUsage', component: TransactionUsageComponent},
    {path: 'NewTransaction', component: NewTransactionComponent}, 
  
    {path: 'BackupIntervall', component: BackupIntervallComponent},
    {path: 'NewBackup', component: NewBackupComponent}, 
    {path: 'LoadBackup', component: LodBackupComponent}*/
];

export const routing = RouterModule.forRoot(routes);