import { Component } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ApiService } from '../../shared/services/api.service';
import { MatSnackBar } from '@angular/material/snack-bar';
import { Route, Router } from '@angular/router';

@Component({
  selector: 'register',
  templateUrl: './register.component.html',
  styleUrl: './register.component.scss',
})
export class RegisterComponent {
  hidePwdContent: boolean = true;
  registerForm: FormGroup;

  constructor(
    private fb: FormBuilder,
    private apiService: ApiService,
    private snackBar: MatSnackBar,
    private router: Router
  ) {
    this.registerForm = fb.group({
      Name: fb.control('', [Validators.required]),
      email: fb.control('', [Validators.required]),
      mobileNumber: fb.control('', [Validators.required]),
      password: fb.control('', [Validators.required]),
      rpassword: fb.control('', [Validators.required]),
    });
  }

  register() {
    let user = {
      Name: this.registerForm.get('Name')?.value,
      email: this.registerForm.get('email')?.value,
      mobileNumber: this.registerForm.get('mobileNumber')?.value,
      password: this.registerForm.get('password')?.value,
    };
    this.apiService.register(user).subscribe({
      next: (res) => {
        this.snackBar.open(res, 'OK');
        this.router.navigate(['/login']);
      },
    });
  }
}
