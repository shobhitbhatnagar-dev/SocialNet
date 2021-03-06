import {Routes} from '@angular/router';
import { HomeComponent } from './home/home.component';
import { MemberListComponent } from './members/member-list/member-list.component';
import { MessagesComponent } from './messages/messages.component';
import { ListComponent } from './list/list.component';
import { AuthGuard } from './_guards/auth.guard';
import { AboutComponent } from './about/about.component';

export const appRoutes: Routes = [
    {path: '', component: HomeComponent},
    {path: 'about', component: AboutComponent},
    {
        path: '',
        runGuardsAndResolvers: 'always',
        canActivate: [AuthGuard],
        children: [
            {path: 'members', component: MemberListComponent},
            {path: 'messages', component: MessagesComponent},
            {path: 'list', component: ListComponent},
        ]
    },
    {path: '**', redirectTo: '', pathMatch: 'full'}
];
