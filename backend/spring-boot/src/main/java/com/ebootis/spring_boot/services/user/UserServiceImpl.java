package com.ebootis.spring_boot.services.user;

import com.ebootis.spring_boot.dtos.UserDTO;
import com.ebootis.spring_boot.mappers.IMapper;
import com.ebootis.spring_boot.models.User;
import com.ebootis.spring_boot.services.generic.CombinedGenericServiceImpl;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Service;

@Service
public class UserServiceImpl extends CombinedGenericServiceImpl<User,UserDTO,Integer> implements IUserService {

    public UserServiceImpl(JpaRepository<User, Integer> repository, IMapper<User, UserDTO> mapper) {
        super(repository, mapper);
    }
}
