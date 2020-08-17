import { Component, OnInit } from '@angular/core';
import { ProductService } from '../services/productService';
import { FormGroup, FormControl, Validators,FormBuilder } from '@angular/forms';
import { Product } from '../models/product';

@Component({
  selector: 'app-productview',
  templateUrl: './productview.component.html',
  styleUrls: ['./productview.component.css']
})
export class ProductviewComponent implements OnInit {
products;
myForm:FormGroup;
showToggle:Boolean;
showModal: Boolean;
product:Product;
id:number;

  constructor(private prodService:ProductService,private fb: FormBuilder) { 
    this.product = new Product();
    this.myForm= this.fb.group({
      ProdId:new FormControl('',Validators.required),
      PName:new FormControl('',Validators.required),
      Quan:new FormControl('',Validators.required),
      Price:new FormControl('',Validators.required),
      Desc:new FormControl('',Validators.required),
      Pic:new FormControl('',Validators.required),
      Col:new FormControl(''),
      Size:new FormControl(''),
      Retailer: new FormControl('',Validators.required),
      Category: new FormControl('',Validators.required),
      Brand: new FormControl('',Validators.required)
    }),
    this.showToggle=false;
  }
  public get ProdId(){
    return this.myForm.get('ProdId');
  }
  public get PName(){
    return this.myForm.get('PName');
  }
  public get Quan(){
    return this.myForm.get('Quan');
  }
  public get Price(){
    return this.myForm.get('Price');
  }
  public get Desc(){
    return this.myForm.get('Desc');
  }
  public get Pic(){
    return this.myForm.get('Pic');
  }
  public get Col(){
    return this.myForm.get('Col');
  }
  public get Size(){
    return this.myForm.get('Size');
  }
  public get Retailer(){
    return this.myForm.get('Retailer');
  }
  public get Category(){
    return this.myForm.get('Category');
  }
  public get Brand(){
    return this.myForm.get('Brand');
  }
 
  get f() {
     return this.myForm.controls;
     }

     initializeFromGroup(){
      this.myForm.setValue({
          ProdId: '',
          PName: '',
          Quan: '',
          Price: '',
          Desc: '',
          Pic: '',
          Col: '',
          Size: '',
          Retailer: '',
          Category: '',
          Brand: ''
      });
  }

  show()
  {
    this.showModal = true; // Show-Hide Modal Check
    
  }
  hide()
  {
    this.myForm.reset();
    this.initializeFromGroup();
    this.showModal = false;
  }
  onSubmit() 
  {
    if(this.myForm.valid)
    {
      this.product.Product_Id=this.ProdId.value;
      this.product.Product_Name=this.PName.value;
      this.product.Quantity=this.Quan.value;
      this.product.Unit_Price=this.Price.value;
      this.product.Product_Description=this.Desc.value;
      this.product.Pictures=this.Pic.value;
      this.product.Color=this.Col.value;
      this.product.Size=this.Size.value;
      this.product.Category_Id=this.Category.value;
      this.product.Retailer_Id=this.Retailer.value;
      this.product.BrandName=this.Brand.value;
      this.prodService.postProduct(this.product).subscribe((data)=>
      {
        //console.log(data);
        this.products = data as [];
      })
      this.hide();
    }
  }
delete()
{
  this.prodService.delProduct(this.id).subscribe((data)=>
  {
    console.log(data);
  })
}
  onClose(){
    this.myForm.reset();
  }

  ngOnInit(): void {
    this.prodService.getProducts().subscribe((data)=>{
      this.products = data;
      //console.log(data);
      })
  }

}
