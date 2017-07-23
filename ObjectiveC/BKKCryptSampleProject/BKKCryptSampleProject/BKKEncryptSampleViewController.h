//
//  BKKEncryptSampleViewController.h
//  BKKCryptSampleProject
//
//  Created by Olah, Andras on 17/07/22.
//  Copyright © 2017 Moszinet. All rights reserved.
//

#import <UIKit/UIKit.h>

@interface BKKEncryptSampleViewController : UIViewController

@property(nonatomic,weak) IBOutlet UITextField *passwordField;              ///< \c UITextField for setting the password.
@property(nonatomic,weak) IBOutlet UITextView *encrptedPasswordField;       ///< \c UITextView for displaying the encrypted password. 

@end

